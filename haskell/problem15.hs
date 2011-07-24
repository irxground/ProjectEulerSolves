fac n = foldl1' (*) [1..n]

com a b = fac a `div` (fac b * fac (a-b))

main = putStrLn $ show $ com 40 20
