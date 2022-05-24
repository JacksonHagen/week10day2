using week10day2.Models;

namespace week10day2.FakeDb
{
  public static class Database
  {
    public static List<Car> Cars { get; set; } = new List<Car>()
    {
        new Car(2007, "Toyota", "FJ Cruiser", "Kinda beat up but it gets the job done.", 10000, "blue", "https://file.kelleybluebookimages.com/kbb/base/house/2008/2008-Toyota-FJ%20Cruiser-FrontSide_TTFJC081_505x375.jpg"),
        new Car(2009, "Toyota", "FJ Cruiser", "Less beat up and it gets the job done.", 15000, "blue", "https://file.kelleybluebookimages.com/kbb/base/house/2008/2008-Toyota-FJ%20Cruiser-FrontSide_TTFJC081_505x375.jpg")
    };
    public static List<House> Houses { get; set; } = new List<House>()
    {
      new House(3, 3, "Pretty sick crib", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQsihWx-22uEl0TQ0x9Mef5n4D7DYw2NQyCGA&usqp=CAU", 2, 600000, 1999),
      new House(2, 2, "Pretty diseased crib", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQsihWx-22uEl0TQ0x9Mef5n4D7DYw2NQyCGA&usqp=CAU", 2, 1000000, 2020)
    };
    public static List<Job> Jobs { get; set; } = new List<Job>()
    {
      new Job("Code Monkey", "Wake up get coffee", "https://media.istockphoto.com/photos/male-chimpanzee-in-business-clothes-picture-id143921954?k=20&m=143921954&s=612x612&w=0&h=trGPQc6w7N-6aZjVjfQTLgkdLV8AljbhjsS5LlBji50=",30),
      new Job("Code Chimp", "Don't wake up or get coffee", "https://media.istockphoto.com/photos/male-chimpanzee-in-business-clothes-picture-id143921954?k=20&m=143921954&s=612x612&w=0&h=trGPQc6w7N-6aZjVjfQTLgkdLV8AljbhjsS5LlBji50=",25)
    };
  }
}