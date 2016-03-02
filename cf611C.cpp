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


int h, v;
char t[510][510];

int r[510][510], c[510][510];

void init(std::istream& in, std::ostream& out){
	for (int i = 0; i < h; i++){
		for (int j = 0; j < v - 1; j++){
			r[i + 1][j + 1] = (t[i][j] == '.' && t[i][j + 1] == '.');
		}
	}
	for (int i = 0; i < h - 1; i++){
		for (int j = 0; j < v; j++){
			c[i + 1][j + 1] = (t[i][j] == '.' && t[i + 1][j] == '.');
		}
	}
	for (int i = 0; i < h; i++){
		for (int j = 0; j < v; j++){
			r[i + 1][j + 1] = r[i + 1][j + 1] + r[i][j + 1] + r[i + 1][j] - r[i][j];
			c[i + 1][j + 1] = c[i + 1][j + 1] + c[i][j + 1] + c[i + 1][j] - c[i][j];
		}
	}

	/*for (int i = 0; i < h; i++){
		for (int j = 0; j < v; j++){
			out << r[i][j];
		}
		out << "\n";
	}*/
}

int query(int r1,int  c1,int  r2, int c2,std::istream& in, std::ostream& out){
	r1--; c1--;

	int a = r[r2][c2 - 1] - r[r2][c1] - r[r1][c2 - 1] + r[r1][c1];
	int b = c[r2 - 1][c2] - c[r2 - 1][c1] - c[r1][c2] + c[r1][c1];
	return a + b;
}

class Solution {
public:
    void solve(std::istream& in, std::ostream& out) {
		in >> h >> v;

		for (int i = 0; i < h; i++){
			in >> t[i];
		}

		init(in, out);
		int nq; in >> nq;

		for (int i = 0; i < nq; i++){
			int r1, c1, r2, c2; in >> r1 >> c1 >> r2 >> c2;
			int ans = query(r1, c1, r2, c2, in, out);

			out << ans << "\n";
		}

		/*for (int i = 0; i < h; i++){
			for (int j = 0; j < v; j++){
				out << t[i][j];
			}
			out << "\n";
		}*/
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}
