using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Core.Commands
{
    internal class MacroStorage
    {
        public MacroStorage()
        {

        }
        public static MacroStorage Instance { get; } = new();
        private List<Macro> _macros = new();
        public void CreateMacro(IEnumerable<ICommand> comands)
        {
            var macro = new Macro(_macros.Count + 1, comands.ToList());
            _macros.Add(macro);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Macro #{macro.Id} saved");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public IEnumerable<Macro> GetMacros() => _macros.AsReadOnly();

        public Macro GetMacro(int id)
        {
            return _macros.First(x=>x.Id == id);
        }
    }
}
