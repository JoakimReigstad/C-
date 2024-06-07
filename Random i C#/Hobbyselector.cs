using System;
using System.Collections.Generic;

namespace RandomHobbyApp
{
    public static class HobbySelector
    {
        public static string DrawRandomHobby(List<string> hobbies)
        {
            var random = new Random();
            int index = random.Next(hobbies.Count);
            return hobbies[index];
        }
    }
}
