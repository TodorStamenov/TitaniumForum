﻿namespace TitaniumForum.Services.Areas.Admin
{
    using Data.Models;
    using Models.Logs;
    using Models.Roles;
    using Models.Users;
    using Services.Models.Users;
    using System.Collections.Generic;

    public interface IAdminUserService
    {
        string GetUsername(int id);

        void Log(string username, LogType action, string tableName);

        bool AddToRole(int userId, string roleName);

        bool RemoveFromRole(int userId, string roleName);

        int Total(string search);

        int Total(string role, string search);

        UserRolesServiceModel Roles(int id);

        IEnumerable<ListLogsServiceModel> Logs(int page, int pageSize, string search);

        IEnumerable<RoleServiceModel> AllRoles();

        IEnumerable<ListUsersServiceModel> All(int page, string role, string search, int pageSize);
    }
}