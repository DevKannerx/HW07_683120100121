import math

class Cylinder:
    # - radius : Real
    # - length : Real
    def __init__(self, radius, length):
        self.__radius = radius
        self.__length = length

    @property
    def radius(self):
        return self.__radius

    @property
    def length(self):
        return self.__length

    # + area() : Real
    def area(self):
        return 2 * math.pi * self.__radius * self.__radius

    # + volume() : Real
    def volume(self):
        return math.pi * self.__radius * self.__radius * self.__length

    # + printInfo()
    def printInfo(self):
        print("Cylinder")
        print("Radius =", self.__radius)
        print("Length =", self.__length)
        print("Area =", self.area())
        print("Volume =", self.volume())
