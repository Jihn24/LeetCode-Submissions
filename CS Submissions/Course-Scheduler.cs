// 1462. Course Schedule IV
// There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1. You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course ai first if you want to take course bi.
//     For example, the pair [0, 1] indicates that you have to take course 0 before you can take course 1.
// Prerequisites can also be indirect. If course a is a prerequisite of course b, and course b is a prerequisite of course c, then course a is a prerequisite of course c.
// You are also given an array queries where queries[j] = [uj, vj]. For the jth query, you should answer whether course uj is a prerequisite of course vj or not.
// Return a boolean array answer, where answer[j] is the answer to the jth query.

var solution = new Solution();
var result = solution.CheckIfPrerequisite(2, new int[][] { new int[] {1, 0} }, new int[][] { new int[] {0, 1}, new int[] {1, 0} });
Console.WriteLine(result[0] + ", " + result[1]);

// Second attempt, I followed a tutorial explaining the Floyd-Warshall algorithm, which is a dynamic programming algorithm used 
// to find the shortest paths in a weighted graph with positive or negative edge weights. 
// In this case, we are using it to find if there is a path from one course to another.
public class Solution {
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) {
        bool[,] relations = new bool[numCourses,numCourses];
        var output = new List<bool>();

        foreach (var course in prerequisites) {
            relations[course[0],course[1]] = true;
        }

        for (int i = 0; i < numCourses; i++) {
            for (int src = 0; src < numCourses; src++) {
                for (int target = 0; target < numCourses; target++) {
                    relations[src, target] = relations[src, target] || (relations[src, i] && relations[i, target]);
                }
            }
        }
        foreach(var query in queries) {
            output.Add(relations[query[0], query[1]]);
        }
        return output;
    }
}


// First attempt came close, going to start over from scratch but want to keep the old code for reference.

/**
public class Solution {
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) {
        List<bool> output = new List<bool>();
        Dictionary<int, List<int>> stored = new Dictionary<int, List<int>>();
        for (int i = 0; i < prerequisites.Length; i++) {
            if (!stored.ContainsKey(prerequisites[i][0])) {
                stored[prerequisites[i][0]] = new List<int>();
            }
            stored[prerequisites[i][0]].Add(prerequisites[i][1]);           
        }

        bool checking;
        bool requis;

        for (int i = 0; i < queries.Length; i++) {
            if (stored.ContainsKey(queries[i][0])) {
                checking = false;
                requis = false;
                int newKey = queries[i][0];
                do {
                    if (stored[newKey].Contains(queries[i][1])) {
                        requis = true;
                        checking = true;
                    } 
                    else {
                        for (int j = 0; j < stored[newKey].Count(); j++) {
                            if (stored.ContainsKey(stored[newKey][j])) {
                                newKey = stored[newKey][j];
                            }
                            else if (j == stored[newKey].Count() - 1) {
                                requis = false;
                                checking = true;
                            }
                        }                        
                    }
                } while (!checking);
                output.Add(requis);
            } else {
                output.Add(false);
            }
            
        }
        
        return output;
    }
}
**/