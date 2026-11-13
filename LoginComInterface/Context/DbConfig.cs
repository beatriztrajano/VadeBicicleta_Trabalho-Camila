using System;
using System.Collections.Generic;
using System.Text;

namespace LoginComInterface.Context
{
    public static class DbConfig
    {
        public static string ConnectionString =>
            "Host=aws-0-us-east-1.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.bxlcvlwmqeyaodlnimje;Password=kDrQyatj13iYkoU2;SSL Mode=Require;Trust Server Certificate=true";
    }
}
