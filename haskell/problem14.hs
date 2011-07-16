import Data.List

nextCollatz n =
	if (n `mod` 2) == 0
		then (n `div` 2)
		else 3 * n + 1

collatzList 1 = [1]
collatzList n = n : collatzList (nextCollatz n)

pairs = [(n, length $ collatzList n) | n <- [1..]]

stepMax left@(n1, step1) right@(n2, step2) = 
	if step1 < step2 then right else left

{-
limit = 1000 * 1000
main = putStrLn $ show $ foldl1' stepMax $ take limit pairs
-}
main = putStrLn $ show $ take 20 pairs

