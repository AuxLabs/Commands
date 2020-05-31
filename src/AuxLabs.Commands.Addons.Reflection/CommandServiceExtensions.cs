using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace AuxLabs.Commands
{
    public static class CommandServiceExtensions
    {
        public static async Task<CommandModel> AddCommandAsync(this ICommandService cmds, Type type)
        {
            await Task.Delay(0);
            return null;
        }

        public static async Task<IEnumerable<CommandModel>> AddCommandsAsync(this ICommandService cmds, Assembly assembly)
        {
            await Task.Delay(0);
            return null;
        }
    }
}
