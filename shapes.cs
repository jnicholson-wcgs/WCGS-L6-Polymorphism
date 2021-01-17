using System;
using System.Collections.Generic;


class MainClass {

  
  // Shape class
  class shape {
    private int x, y;
    private string name;
    public shape (string name, int x, int y) {
      this.x = x;
      this.y = y;
      this.name = name;
    }
    // Method to calculate the area of a shape
    public  double area () {
      Console.WriteLine ("shape(): not sure how to calculate my area");
      return 0.0;
    }
    public string getName() {return name;}
    public void draw () {
      Console.WriteLine ("Draw {0}", name);
    }
  }

  // Circle inherits from shape.

  class circle : shape {
    private double radius;
    public circle (int x, int y, double r) : base ("Circle", x, y) {
      radius = r;
    }
    public  new double area () {
      return (3.14 * radius * radius);
    }
  }
  public static void Main (string[] args) {
    // Shapes collection
    List<shape> shapes = new List<shape>();

    Console.WriteLine ("Hello to Shape World");

    circle c = new circle (0, 0, 3.2);
    shapes.Add (c);
    shapes.Add (new circle (0, 0, 4.0));

    // Add your other shapes here.......
    //
    foreach (var s in shapes) {
      Console.WriteLine ("Shape: {0}", s.getName());
    }
    
  }
}
