using System.Drawing;
using Line.Messaging;
using Line.Messaging.Webhooks;

public class LineService : ILineService
{
    public LineService()
    {
    }

    public async Task<List<ISendMessage>> ProcessTextEventMessageAsync(string channelId, string userId, string message)
    {
        var result = null as List<ISendMessage>;

        /*
        if (message.Contains("370Z"))
        {
            return  new List<ISendMessage>
            {
                new ImageMessage(originalContentUrl:"https://www.nissan.ca/content/dam/Nissan/Canada/Vehicles/Z/2024/nismo/side-view-of-nissan-z-nismo-in-grey.jpg"
                    ,previerImageUrl:"https://www.nissan.ca/content/dam/Nissan/Canada/Vehicles/Z/2024/nismo/side-view-of-nissan-z-nismo-in-grey.jpg"
                    ,quickReply:null),
            };    
        }*/
        
        string[] imageUrl = new string[]
        {
            "https://www.nissan.ca/content/dam/Nissan/Canada/Vehicles/Z/2024/nismo/side-view-of-nissan-z-nismo-in-grey.jpg",
            "https://image.cache.u-car.com.tw/articleimage_1213121.jpg",
            "https://www.carstuff.com.tw/media/k2/items/cache/c79b4f75742ca3f9e749cd0f1875b746_XL.jpg",
        };
        Random rnd = new Random( (int)DateTime.Now.TimeOfDay.TotalSeconds);
        int index= rnd.Next(0, imageUrl.Length);


        return  new List<ISendMessage>
        {
            new ImageMessage(imageUrl[index],imageUrl[index],null),
        };
        
        result = new List<ISendMessage>
        {
            new ImageMessage(originalContentUrl:"https://www.nissan.ca/content/dam/Nissan/Canada/Vehicles/Z/2024/nismo/side-view-of-nissan-z-nismo-in-grey.jpg"
                ,previerImageUrl:"https://www.nissan.ca/content/dam/Nissan/Canada/Vehicles/Z/2024/nismo/side-view-of-nissan-z-nismo-in-grey.jpg"
                ,quickReply:null),
            new TextMessage($"Receive a text event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessStickerEventMessageAsync(string channelId, string userId,string packageId, string stickerId)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a sticker event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId,string originalContentUrl,
        string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId, Image image)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessVideoEventMessageAsync(string channelId, string userId,string originalContentUrl, string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a video event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessAudioEventMessageAsync(string channelId, string userId,string originalContentUrl, int duration)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a audio event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessLocationEventMessageAsync(string channelId, string userId,string title, string address, float latitude, float longitude)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a location event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
}