using System;
using System.Xml.Linq;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

source userSetting = new source { name = null, server = null, language = "English", volume = null };
source profileSetting = new source { name = "프로필유저", server = null, language = "Korean", volume = null };
source globalSetting = new source { name = null, server = null, language = "Japanese", volume = 70 };
source defaultValue = new source { name = "Player", server = "localhost", language = "Korean", volume = 50 };

source set = new source
{
    name = userSetting.name ?? profileSetting.name ?? globalSetting.name ?? defaultValue.name,
    server = userSetting.server ?? profileSetting.server ?? globalSetting.server ?? defaultValue.server,
    language = userSetting.language ?? profileSetting.language ?? globalSetting.language ?? defaultValue.language,
    volume = userSetting.volume ?? profileSetting.volume ?? globalSetting.volume ?? defaultValue.volume,
};



struct source
{
    public string name;
    public string server;
    public  string language;
    public int? volume;
}