import pyodbc

def get_sql_data(query):
    conn = pyodbc.connect(
        "Driver={SQL Server};"
        "Server=DESKTOP-G6QRO2F;"
        "Database=WEB_APP_QLKS;"
        "Trusted_Connection=yes;"
    )
    cursor = conn.cursor()
    cursor.execute(query)

    columns = [column[0] for column in cursor.description]
    results = [dict(zip(columns, row)) for row in cursor.fetchall()]

    conn.close()
    return results
