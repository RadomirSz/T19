import unittest
import zadanie_radomir

class MyTestCase(unittest.TestCase):
    def test_liczba_lustrzana(self):
        result = zadanie_radomir.liczba_lustrzana(234)
        self.assertEqual(result, 432)
    def test_suma_neg(self):
        result = zadanie_radomir.liczba_cyfr(2734)
        self.assertEqual(result, 4)

class MyTestCase2(unittest.TestCase):
    def test_liczba_lustrzana(self):
        result = zadanie_radomir.liczba_lustrzana(348721)
        self.assertEqual(result, 127843)
    def test_suma_neg(self):
        result = zadanie_radomir.liczba_cyfr(9816523979872653)
        self.assertEqual(result, 16)

class MyTestCase3(unittest.TestCase):
    def test_liczba_lustrzana(self):
        result = zadanie_radomir.liczba_lustrzana("abc")
        self.assertEqual(result, False)
    def test_suma_neg(self):
        result = zadanie_radomir.liczba_cyfr("abc")
        self.assertEqual(result, False)


if __name__ == '__main__':
    unittest.main()