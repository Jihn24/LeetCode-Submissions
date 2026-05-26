# 1462. Course Schedule IV
# There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1. You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course ai first if you want to take course bi.
#     For example, the pair [0, 1] indicates that you have to take course 0 before you can take course 1.
# Prerequisites can also be indirect. If course a is a prerequisite of course b, and course b is a prerequisite of course c, then course a is a prerequisite of course c.
# You are also given an array queries where queries[j] = [uj, vj]. For the jth query, you should answer whether course uj is a prerequisite of course vj or not.
# Return a boolean array answer, where answer[j] is the answer to the jth query.

class Solution:
    def checkIfPrerequisite(self, numCourses, prerequisites, queries):
        adj =[[] for _ in range(numCourses)]
        for prereq,crs in prerequisites:
            adj[crs].append(prereq)

        def dfs(crs):
            if crs not in prereqMap:
                prereqMap[crs] = set()
                for prereq in adj[crs]:
                    prereqMap[crs] = prereqMap[crs] | dfs(prereq)
                prereqMap[crs].add(crs)
            return prereqMap[crs]

        prereqMap = {}
        for crs in range(numCourses):
            dfs(crs)

        output = []

        for u,v in queries:
            output.append(u in prereqMap[v])

        return output

solution = Solution()
print(solution.checkIfPrerequisite(2, [[1,0]], [[0,1],[1,0]])) # [False, True]