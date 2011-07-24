import Ratio

root2s = (toRational 1) : map next root2s
	where next a = 1 + 1 / (a + 1)

ans = length [x| x <- take 1000 root2s, cond x] where
	cond x = ketaLen (numerator x) > ketaLen (denominator x)
	ketaLen n = length $ show n

main = print ans
