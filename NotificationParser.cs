using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class NotificationParser
{
    private static readonly HashSet<string> ValidChannels = new HashSet<string> { "BE", "FE", "QA", "Urgent" };
    public static string ParseNotificationTitle(string title)
    {
    
        Regex regex = new Regex(@"\[(.*?)\]");
        MatchCollection matches = regex.Matches(title);
        HashSet<string> channels = new HashSet<string>();
        foreach (Match match in matches)
        {
            string tag = match.Groups[1].Value;
            if (ValidChannels.Contains(tag))
            {
                channels.Add(tag);
            }
        }
        return channels.Count > 0 
            ? $"Receive channels: {string.Join(", ", channels)}" 
            : "No valid channels found";
    }
}
