# Definition for a pair.
# class Pair:
#     def __init__(self, key: int, value: str):
#         self.key = key
#         self.value = value
class Solution:
    def insertionSort(self, pairs: List[Pair]) -> List[List[Pair]]:
        if len(pairs) is 0: return []
        output = [pairs.copy()]
        for i in range(1, len(pairs)):
            temp = pairs[i]
            j = i - 1
            while j >= 0 and pairs[j].key > temp.key:
                pairs[j+1] = pairs[j]
                j -= 1
            pairs[j+1] = temp
            output.append(pairs.copy())
        return output