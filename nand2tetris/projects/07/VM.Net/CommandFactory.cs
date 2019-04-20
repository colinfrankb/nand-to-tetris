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
                case "pop":
                    return new Pop(segment, index);
                case "add":
                    return new Add();
                case "sub":
                    return new Sub();
                case "eq":
                    return new Eq();
                case "lt":
                    return new Lt();
                case "gt":
                    return new Gt();
                case "neg":
                    return new Neg();
                case "and":
                    return new And();
                case "or":
                    return new Or();
                case "not":
                    return new Not();

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
