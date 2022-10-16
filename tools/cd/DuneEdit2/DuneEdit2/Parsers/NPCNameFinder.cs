namespace DuneEdit2.Parsers
{
    /// <summary>
    /// From ODRADE: https://github.com/debrouxl/odrade
    /// </summary>
    internal static class NPCNameFinder
    {
        private const string UnknownValue = "Unknown/Unused NPC Sprite ID";

        public static string GetNPCName(int id)
        {
            return id switch
            {
                0x00 => "Duke Leto Atreides",
                0x01 => "Jessica Atreides",
                0x02 => "Thufir Hawat",
                0x03 => "Duncan Idaho",
                0x04 => "Gurney Halleck",
                0x05 => "Stilgar",
                0x06 => "Liet Kynes",
                0x07 => "Chani",
                0x08 => "Harah",
                0x09 => "Baron Vladimir Harkonnen",
                0x0a => "Feyd-Rautha Harkonnen",
                0x0b => "Emperor Shaddam IV",
                0x0c => "Harkonnen Captains",
                0x0d => "Smugglers",
                0x0e => "Fremen Chef",
                0x0f => "Fremen Chef",
                _ => UnknownValue,
            };
        }
    }
}
