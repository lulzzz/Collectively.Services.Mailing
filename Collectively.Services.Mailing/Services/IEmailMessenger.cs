﻿using System;
using System.Threading.Tasks;

namespace Collectively.Services.Mailing.Services
{
    public interface IEmailMessenger
    {
        Task SendResetPasswordAsync(string email, string endpoint, string token, string culture);

        Task SendRemarkCreatedAsync(string email, Guid remarkId, 
            string category, string address, string username,
            DateTime date, string culture);

        Task SendRemarkStateChangedAsync(string email, Guid remarkId,
            string category, string address, string username,
            DateTime date, string culture, string state);

        Task SendCommentAddedToRemarkAsync(string email, Guid remarkId,
            string category, string address, string username,
            DateTime date, string culture, string comment);

        Task SendPhotosAddedToRemarkEmailAsync(string email, Guid remarkId,
            string category, string address, string username,
            DateTime date, string culture);
    }
}