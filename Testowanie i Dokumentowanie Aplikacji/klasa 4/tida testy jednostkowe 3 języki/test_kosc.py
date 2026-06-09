import pytest

from Kosc import Kosc


def test_Rzut_GdyDostepna_ZwracaWartoscZPrzedzialu1Do6():
    kosc = Kosc()

    kosc.Rzut()

    assert 1 <= kosc.LiczbaOczek <= 6


def test_Rzut_GdyNiedostepna_NieZmieniaWartosci():
    kosc = Kosc(3)
    kosc.Blokuj()

    kosc.Rzut()

    assert kosc.LiczbaOczek == 3
