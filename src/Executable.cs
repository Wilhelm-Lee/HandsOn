namespace Foundational;

interface Executable
{
    int Execute(string[] args, string[] envs);
    int Execute(string[] args);
    int Execute();
}
