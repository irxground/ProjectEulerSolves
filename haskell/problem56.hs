import Char

sumDigit num = sum [digitToInt c | c <- show num]

ans = maximum [sumDigit (a^b) | a <- [1..100], b <- [1..100]]

main = putStrLn $ show ans


