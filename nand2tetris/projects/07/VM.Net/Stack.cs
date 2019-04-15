using System.Text;

namespace VM.Net
{
    public class Stack
    {
        private int StackPointer { get; set; }

        public string PushD()
        {
            var assemblyInstruction = new StringBuilder();

            assemblyInstruction.Append($"@{StackPointer}");
            assemblyInstruction.Append($"M=D");

            return assemblyInstruction.ToString();
        }

        public void Pop(int value)
        { }
    }
}
