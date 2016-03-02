#include <algorithm>
#include <iomanip>
#include <istream>
#include <map>
#include <numeric>
#include <ostream>
#include <set>
#include <sstream>
#include <string>
#include <utility>
#include <vector>
using namespace std;
// Powered by caide (code generator, tester, and library code inliner)


class Solution {
public:
    void solve(std::istream& in, std::ostream& out) {
		string s, t; in >> s >> t;

		vector<int> sc(27, 0);
		vector<int> tc(27, 0);

		for (int i = 0; i < s.length(); i++){
			sc[s[i] - 'a']++;
		}

		for (int i = 0; i < t.length(); i++){
			tc[t[i] - 'a']++;
		}

		if (s.length() < t.length()){
			out << "need tree";
			return;
		} 

		if (s.length() == t.length()){
			for (int i = 0; i < 26; i++){
				if (sc[i] != tc[i])
				{
					out << "need tree";
					return;
				}
			}
			out << "array";
			return;
		}

		if (s.length() > t.length()){

			for (int i = 0; i < 26; i++){
				if (sc[i] < tc[i])
				{
					out << "need tree";
					return;
				}
			}
		}




		int ind = 0;
		for (int i = 0; i < s.length(); i++){
			if (s[i] == t[ind]){
				ind++;
			}
		}

		//out << ind << "\n";

		if (ind == t.length()){
			out << "automaton";
		}
		else{
			out << "both";
		}


    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
