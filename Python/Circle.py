import math

class Circle:
    # - radius : Real
    def __init__(self, radius):
        self.__radius = radius

    @property
    def radius(self):
        return self.__radius

    # + area() : Real
    def area(self):
        return math.pi * self.__radius * self.__radius

    # + printInfo()
    def printInfo(self):
        print("Circle")
        print("Radius =", self.__radius)
        print("Area =", self.area())
