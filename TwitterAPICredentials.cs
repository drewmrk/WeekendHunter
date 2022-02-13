/// <summary>
///   Twitter API credentials
/// </summary>
class TwitterAPICredentials {
  public string consumerKey = "";
  public string consumerSecret = "";
  public string accessKey = "";
  public string accessSecret = "";

  /// <summary>
  ///   Get the Twitter API credentials
  /// </summary>
  public TwitterAPICredentials() {
    Console.Write("Consumer Key: ");
    this.consumerKey = Console.ReadLine() ?? throw new ArgumentException("Consumer Key cannot be null");

    Console.Write("Consumer Secret: ");
    this.consumerSecret = Console.ReadLine() ?? throw new ArgumentException("Consumer Secret cannot be null");

    Console.Write("Access Key: ");
    this.accessKey = Console.ReadLine() ?? throw new ArgumentException("Access Key cannot be null");

    Console.Write("Access Secret: ");
    this.accessSecret = Console.ReadLine() ?? throw new ArgumentException("Access Secret cannot be null");
  }
}
