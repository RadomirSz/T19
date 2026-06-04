def _normalize_number(number: str) -> str:
    cleaned = number.replace(" ", "").replace("-", "")
    if not cleaned.isdigit():
        return ""
    return cleaned


def luhn_valid(number: str) -> bool:
    """
    Waliduje numer według algorytmu Luhna.

    :param number: Numer do zweryfikowania. Powinien być ciągiem znaków
        zawierającym cyfry.

    :return: Wartość logiczna wskazująca, czy podany numer jest
        prawidłowy zgodnie z algorytmem Luhna.
    :rtype: bool
    """
    cleaned = _normalize_number(number)
    if not cleaned:
        return False

    total = 0
    double = False
    for ch in reversed(cleaned):
        digit = int(ch)
        if double:
            digit *= 2
            if digit > 9:
                digit -= 9
        total += digit
        double = not double

    return total % 10 == 0


def main() -> None:
    raw = input("Podaj numer karty: ")
    if luhn_valid(raw):
        print("Numer karty jest poprawny według walidacji Luhna.")
    else:
        print("Numer karty jest niepoprawny walidacji Luhna.")


if __name__ == "__main__":
    main()
