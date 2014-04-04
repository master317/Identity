﻿using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Identity
{
    /// <summary>
    ///     Stores whether two factor is enabled for a user
    /// </summary>
    /// <typeparam name="TUser"></typeparam>
    public interface IUserTwoFactorStore<TUser> : IUserStore<TUser> where TUser : class
    {
        /// <summary>
        ///     Sets whether two factor is enabled for the user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="enabled"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task SetTwoFactorEnabled(TUser user, bool enabled, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Returns whether two factor is enabled for the user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> GetTwoFactorEnabled(TUser user, CancellationToken cancellationToken = default(CancellationToken));
    }
}