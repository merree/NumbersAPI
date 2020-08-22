# NumbersAPI

Here are some details to call the API endpoint to get divison result;

URL:
http://localhost:5500/api/Numbers/GetDivisionResult

REQUEST TYPE:
POST
 
REQUIRED HEADERS:
api-security-key: abc123

SAMPLE DATA TO POST:
{
  "dividends": [10, 14, 12, 1],
  "divisor": 2.5
}

SAMPLE RESPONSE:
{
    "quotients": [
        4,
        5.6,
        4.8,
        0.4
    ]
}
