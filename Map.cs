/// <summary>
///   Map
/// </summary>
class Map {
  public string visual = @"
*****************
* x x x x x x x *
*****************
";

  public string original = @"
*****************
* x x x x x x x *
*****************
";

  /// <summary>
  ///   Reset the map back to its original and unchanged state
  /// </summary>
  public void Reset() {
    this.visual = this.original;
  }

  /// <summary>
  ///   Place the hunter at a specific index on the map
  /// </summary>
  /// <param name="index">
  ///   The index the hunter is to be placed at
  /// </param>
  /// <param name="hunter">
  ///   The hunter
  /// </param>
  public void PlaceHunter(int index, string hunter) {
    Reset();

    string tempVisual = this.visual;

    for (int i = 0; i < this.visual.Length; i++) {
      if (i == index) {
        tempVisual += hunter;
      } else {
        tempVisual += this.visual[i];
      }
    }

    this.visual = tempVisual;
  }
}
