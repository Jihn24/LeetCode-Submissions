// 1462. Course Schedule IV
// There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1. You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course ai first if you want to take course bi.
//     For example, the pair [0, 1] indicates that you have to take course 0 before you can take course 1.
// Prerequisites can also be indirect. If course a is a prerequisite of course b, and course b is a prerequisite of course c, then course a is a prerequisite of course c.
// You are also given an array queries where queries[j] = [uj, vj]. For the jth query, you should answer whether course uj is a prerequisite of course vj or not.
// Return a boolean array answer, where answer[j] is the answer to the jth query.

import java.util.ArrayList;
import java.util.List;

class Solution {
    public List<Boolean> checkIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) {
        boolean[][] relations = new boolean[numCourses][numCourses];
        List<Boolean> output = new ArrayList<>();

        for (var course : prerequisites) {
            relations[course[0]][course[1]] = true;
        }

        for (int i = 0; i < numCourses; i++) {
            for (int src = 0; src < numCourses; src++) {
                for (int target = 0; target < numCourses; target++) {
                    relations[src][target] = relations[src][target] || (relations[src][i] && relations[i][target]);
                }
            }
        }
        for (var query : queries) {
            output.add(relations[query[0]][query[1]]);
        }
        return output;
    }

    public static void main(String[] args) {
        var solution = new Solution();
        System.out.println(solution.checkIfPrerequisite(2, new int[][]{{1, 0}}, new int[][]{{0, 1}, {1, 0}}));
        System.out.println(solution.checkIfPrerequisite(2, new int[][]{{1, 0}}, new int[][]{{1, 0}, {0, 1}}));
    }
}