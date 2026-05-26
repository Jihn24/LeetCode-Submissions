// 1462. Course Schedule IV
// There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1. You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course ai first if you want to take course bi.
//     For example, the pair [0, 1] indicates that you have to take course 0 before you can take course 1.
// Prerequisites can also be indirect. If course a is a prerequisite of course b, and course b is a prerequisite of course c, then course a is a prerequisite of course c.
// You are also given an array queries where queries[j] = [uj, vj]. For the jth query, you should answer whether course uj is a prerequisite of course vj or not.
// Return a boolean array answer, where answer[j] is the answer to the jth query.

#include <vector>
using namespace std;

class Solution {
public:
    vector<bool> checkIfPrerequisite(int numCourses, vector<vector<int>>& prerequisites, vector<vector<int>>& queries) {
        vector<vector<bool>> relations(numCourses, vector<bool>(numCourses, false));
        vector<bool> output;

        for (auto course : prerequisites) {
            relations[course[0]][course[1]] = true;
        }

        for (int i = 0; i < numCourses; i++) {
            for (int src = 0; src < numCourses; src++) {
                for (int target = 0; target < numCourses; target++) {
                    relations[src][target] = relations[src][target] || (relations[src][i] && relations[i][target]);
                }
            }
        }
        for (auto query : queries) {
            output.push_back(relations[query[0]][query[1]]);
        }
        return output;
    }
};