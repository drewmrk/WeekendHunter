/// <summary>
///   Hunter
/// </summary>
class Hunter {
  public Map map = new();

  /// <summary>
  ///   Setup the map for the hunter to use
  /// </summary>
  /// <param name="map">
  ///   The map to be used by the hunter
  /// </param>
  public Hunter(Map map) {
    this.map = map;
  }

  /// <summary>
  ///   Move the hunter forward and set their expression based on the day of the week
  /// </summary>
  public void MoveForward() {
    switch (DateTime.Today.DayOfWeek) {
      case DayOfWeek.Sunday:
        this.map.PlaceHunter(23, "😐");
        break;
      case DayOfWeek.Monday:
        this.map.PlaceHunter(25, "😢");
        break;
      case DayOfWeek.Tuesday:
        this.map.PlaceHunter(27, "☹️");
        break;
      case DayOfWeek.Wednesday:
        this.map.PlaceHunter(29, "😐");
        break;
      case DayOfWeek.Thursday:
        this.map.PlaceHunter(31, "🙂");
        break;
      case DayOfWeek.Friday:
        this.map.PlaceHunter(33, "☺️");
        break;
      case DayOfWeek.Saturday:
        this.map.PlaceHunter(35, "🤗");
        break;
      default:
        map.Reset();
        break;
    }
  }
}