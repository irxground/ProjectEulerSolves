import Char

sumDigit = sum . map digitToInt . show

ans = maximum [sumDigit (a^b) | a <- [1..100], b <- [1..100]]

main = print ans


