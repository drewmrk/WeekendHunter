using Tweetinvi;

Console.WriteLine("WeekendHunter\n");

Map map = new();
Hunter hunter = new(map);

TwitterAPICredentials twitterAPICredentials = new();

/// <summary>
///   Tweet
/// </summary>
/// <param name="tweet">
///   The tweet to be tweeted
/// </param>
/// <param name="twitterClient">
///   The Twitter API
/// </param>
async Task Tweet(string tweet, TwitterClient twitterClient) {
  Tweetinvi.Models.ITweet tweetTweet = await twitterClient.Tweets.PublishTweetAsync(tweet);
}

TwitterClient twitterClient = new(twitterAPICredentials.consumerKey,
                                  twitterAPICredentials.consumerSecret,
                                  twitterAPICredentials.accessKey,
                                  twitterAPICredentials.accessSecret);

while (true) {
  if (DateTime.Now.Hour == 0 &&
      DateTime.Now.Minute == 0 &&
      DateTime.Now.Second == 0) {
    hunter.MoveForward();
    Console.WriteLine(map.visual);
    await Tweet(map.visual, twitterClient);
  }
}
