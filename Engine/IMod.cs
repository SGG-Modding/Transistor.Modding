﻿namespace Modding
{
    public interface IMod
    {

        string Name { get; }

        string Version { get; }

        void Initialize();

    }
}
