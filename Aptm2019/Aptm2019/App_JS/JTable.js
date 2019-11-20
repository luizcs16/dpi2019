class JTableFilter {
    constructor(ColumnNames, Value, SQL_Like) {
        if (Array.isArray(ColumnNames))
            this.ColumnNames = ColumnNames;
        else if (typeof (ColumnNames) === 'string')
            this.ColumnNames = [ColumnNames];
        else
            throw 'Error al crear el filtro.';
        this.Value = Value;
        this.SQL_Like = SQL_Like;
    }
}