class Rectangle:
    # - width : Real
    # - height : Real
    def __init__(self, width, height):
        self.__width = width
        self.__height = height

    @property
    def width(self):
        return self.__width

    @property
    def height(self):
        return self.__height

    # + area() : Real
    def area(self):
        return self.__width * self.__height

    # + printInfo()
    def printInfo(self):
        print("Rectangle")
        print("Width =", self.__width)
        print("Height =", self.__height)
        print("Area =", self.area())
