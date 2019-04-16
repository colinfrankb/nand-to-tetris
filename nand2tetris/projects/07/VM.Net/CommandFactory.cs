using System;
using VM.Net.Commands;

namespace VM.Net
{
    public class CommandFactory
    {
        public Command Create(string line)
        {
            var commandFields = line.Split(' ');
            var commandName = commandFields[0];
            var segment = commandFields.Length > 1 ? commandFields[1] : null;
            var index = commandFields.Length > 2 ? commandFields[2] : null;

            switch (commandName)
            {
                case "push":
                    return new Push(segment, index);
                case "add":
                    return new Add();

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
