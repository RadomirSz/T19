
# import unitest
# nazwa pliku test_toco chce testować
import unittest
import euklides  # import py file

class MyTestCase(unittest.TestCase):
    def test_something(self):# argumentem jest self
        self.assertEqual( euklides.euklides(12,16),4) # sprawdzam czy wynik jest to co chce
        self.assertEqual(euklides.euklides(24, 16), 8)
        self.assertEqual( euklides.euklides(30,20),10)
        self.assertEqual( euklides.euklides(36,24),12)


if __name__ == '__main__':
    unittest.main()
