import Data.List

power n e = product $ take e $ repeat n

num = "0123456789"
c2n c = case elemIndex c num of
	Just n  -> n
	Nothing -> 0

value = sum $ map c2n $ show $ power 2 1000
main = putStrLn $ show $ value
