using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Core.Commands
{
    internal class CommandInvoker
    {
        private List<ICommand> _commands = new();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
            ClearCommands();
        }

        public void ClearCommands()
        {
            _commands.Clear();  
        }

        public IEnumerable<ICommand> GetCommands() =>_commands.AsReadOnly();  
    }
}
