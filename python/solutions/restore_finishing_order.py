class RestoreFinishingOrder:

    def solution(self,order,friends):
        
        result = []
        map = {}
        
        for i,name in enumerate(friends):
            map[name] = name

        for i,name in enumerate(order):
            if name in map:
                result.append(map[name])

        return result