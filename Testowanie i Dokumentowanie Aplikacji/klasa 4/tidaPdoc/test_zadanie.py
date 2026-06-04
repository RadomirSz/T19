import unittest

from zadanie import luhn_valid


class TestLuhn(unittest.TestCase):
    def testWalidacjiLuhna_GdyPoprawnyNumer_PowinienBycPrawdziwy(self) -> None:
        self.assertTrue(luhn_valid("49927398716"))

    def testWalidacjiLuhna_GdyNiePoprawnyNumer_PowinienBycFalszywy(self) -> None:
        self.assertFalse(luhn_valid("49927398717"))


if __name__ == "__main__":
    unittest.main()