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

        private Stack<ICommand> _executeCommands = new Stack<ICommand>();
        private Stack<ICommand> _undoneCommands = new Stack<ICommand>();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                ExecuteCommand(command);
            }
            ClearCommands();
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _executeCommands.Push(command); 
        }
        public void Undo( )
        {
            var command = _executeCommands.Pop();   
            command.Undo();
            _undoneCommands.Push(command);
        }
        public void Redo()
        {
            var command = _undoneCommands.Pop();
            ExecuteCommand(command);
        }

        public void ClearCommands()
        {
            _commands.Clear();  
        }

        public IEnumerable<ICommand> GetCommands() =>_commands.AsReadOnly();  
    }
}
