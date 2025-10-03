class DecodeTheMessage:
    def solution(self,key,message):
        result = ""
        start = 'a'
        map = {}
        for i,word in enumerate(key.replace(" ","")):
            if word not in map:
                map[word] = start
                start = chr(ord(start) + 1)

        for i,word in enumerate(message):
            if word == " ":
                result += " "
            else:
                result += map[word]

        return result