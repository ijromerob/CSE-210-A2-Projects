public class ScriptureGenerator
{
    private List<string> _scripturesList = new List<string>()
    {
       "Proverbs~3~5~6--Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
       "1 Nephi~3~7--And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
       "1 Nephi~10~18~19--For he is the same yesterday, today, and forever; and the way is prepared for all men from the foundation of the world, if it so be that they repent and come unto him. For he that diligently seeketh shall find; and the mysteries of God shall be unfolded unto them, by the power of the Holy Ghost, as well in these times as in times of old, and as well in times of old as in times to come; wherefore, the course of the Lord is one eternal round.",
       "John~3~16--For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
       "Mosiah~3~19--For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.",
    };

    public string GetRandomScripture()
    {
        Random rnd = new Random();
        int index = rnd.Next(_scripturesList.Count);
        string prompt = _scripturesList[index];
        return prompt;
    }
}