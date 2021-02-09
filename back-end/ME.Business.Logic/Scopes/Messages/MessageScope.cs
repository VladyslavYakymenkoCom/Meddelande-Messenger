using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Mapster;
using ME.Business.Logic.Abstraction.Models.Messages;
using ME.Business.Logic.Abstraction.Scopes.Messages;
using ME.Business.Logic.Exceptions;
using ME.Business.Logic.Specifications;
using ME.Business.Logic.Specifications.Messages;
using ME.Data.Access.Abstractions.UnitOfWork;
using ME.Data.Models.Messages;
using Microsoft.EntityFrameworkCore;

namespace ME.Business.Logic.Scopes.Messages
{
    public class MessageScope : IMessageScope
    {
        #region Dependencies
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        public MessageScope(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Crud
        public async Task<MessageModel> GetByIdAsync(Guid id)
        {
            var message = await _unitOfWork.Message.FirstAsync(
                new ByIdSpecification<Message>(id)
                && new ActiveSpecification<Message>()
                );
            if (message is null)
                throw new NotFoundException();

            return message.Adapt<MessageModel>();
        }

        public async Task<MessageModel> CreateAsync(MessageToCreateModel model)
        {
            model.ValidateAndThrow();

            var entityToCreate = model.Adapt<Message>();
            var message = await _unitOfWork.Message.CreateAsync(entityToCreate);

            await _unitOfWork.CommitAsync();
            return await GetByIdAsync(message.Id);
        }

        public async Task<MessageModel> UpdateAsync(MessageToUpdateModel model)
        {
            model.ValidateAndThrow();

            var message = await _unitOfWork.Message.FirstAsync(new ByIdSpecification<Message>(model.Id));
            if (message is null)
                throw new NotFoundException();

            message.Body = model.Body;
            message.UpdatedAt = DateTime.UtcNow;

            await _unitOfWork.CommitAsync();
            return await GetByIdAsync(message.Id);
        }

        public void Delete(Guid id)
        {
            var message = _unitOfWork.Message.First(new ByIdSpecification<Message>(id));
            if (message is null)
                throw new NotFoundException();

            message.UpdatedAt = DateTime.UtcNow;
            message.IsDeactivated = true;

            _unitOfWork.Commit();
        }
        #endregion

        public IEnumerable<MessageModel> GetForChat(Guid chatId)
        {
            var messages = _unitOfWork.Message.GetAll(
                    new MessageByChatIdSpecification(chatId)
                    && new ActiveSpecification<Message>()
                    )
                .Include(m => m.Author)
                .ToImmutableList();

            return messages?.Adapt<IEnumerable<MessageModel>>();
        }
    }
}
