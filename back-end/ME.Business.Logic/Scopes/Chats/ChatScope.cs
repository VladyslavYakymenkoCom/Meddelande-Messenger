using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using ME.Business.Logic.Abstraction.Models.Chats;
using ME.Business.Logic.Abstraction.Scopes.Chats;
using ME.Business.Logic.Exceptions;
using ME.Business.Logic.Specifications;
using ME.Business.Logic.Specifications.Chats;
using ME.Data.Access.Abstractions.UnitOfWork;
using ME.Data.Models.Chats;
using Microsoft.EntityFrameworkCore;

namespace ME.Business.Logic.Scopes.Chats
{
    public class ChatScope : IChatScope
    {
        #region Dependencies
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        public ChatScope(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Crud
        public async Task<ChatModel> GetByIdAsync(Guid id)
        {
            var chat = await _unitOfWork.Chat.FirstAsync(
                new ByIdSpecification<Chat>(id)
                && new ActiveSpecification<Chat>()
                );
            if (chat is null)
                throw new NotFoundException();

            return chat.Adapt<ChatModel>();
        }

        public async Task<ChatModel> CreateAsync(ChatToCreateModel model)
        {
            model.ValidateAndThrow();

            var entityToCreate = model.Adapt<Chat>();
            var chat = await _unitOfWork.Chat.CreateAsync(entityToCreate);

            #region Participants
            foreach (var id in model.ParticipantIds)
                await _unitOfWork.Chat.AddParticipantAsync(id, chat.Id);
            #endregion

            await _unitOfWork.CommitAsync();
            return await GetByIdAsync(chat.Id);
        }

        public async Task<ChatModel> UpdateAsync(ChatToUpdateModel model)
        {
            model.ValidateAndThrow();

            var chat = await _unitOfWork.Chat.FirstAsync(new ByIdSpecification<Chat>(model.Id));
            if (chat is null)
                throw new NotFoundException();

            chat.Title = model.Title;
            chat.UpdatedAt = DateTime.UtcNow;

            await _unitOfWork.CommitAsync();
            return await GetByIdAsync(chat.Id);
        }

        public void Delete(Guid id)
        {
            var chat = _unitOfWork.Chat.First(new ByIdSpecification<Chat>(id));
            if (chat is null)
                throw new NotFoundException();

            chat.UpdatedAt = DateTime.UtcNow;
            chat.IsDeactivated = true;

            _unitOfWork.Commit();
        }
        #endregion

        public IEnumerable<ChatListItemModel> GetForUser(Guid userId)
        {
            var chats = _unitOfWork.Chat.GetAll(
                new ChatByParticipantIdSpecification(userId)
                && new ActiveSpecification<Chat>()
                )
                .Include(ch => ch.Participants.Select(p => p.User))
                .Include(ch => ch.Messages.Select(m => m.Author))
                .ToImmutableArray();

            return chats.Adapt<IEnumerable<ChatListItemModel>>();
        }
    }
}
