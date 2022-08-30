using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticalWorldSim.Services
{
    public interface IInteractionService
    {
        T GetOption<T>(string prompt, params T[] args);
        string? GetText(string prompt);
    }
}
