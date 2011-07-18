a = 21 ^ 7
b = 7 ^ 21
c = 12 ^ 7

f n
	| n > b     = n - c
	| otherwise = f(a+f(a+f(a+f(a+n))))

ans = sum [f(n) | n <- [0 .. b]]
main = putStrLn $ show $ ans

