﻿namespace CribMaker.Services.Services.Factory
{
    public interface IServiceManager
    {
        IApplicationUserService ApplicationUserService { get; }

        IPupilService PupilService { get; }
    }
}