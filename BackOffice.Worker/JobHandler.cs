﻿using BackOffice.Common;
using BackOffice.Jobs.Interfaces;
using BackOffice.Jobs.Reports;
using System;

namespace BackOffice.Worker
{
    public class JobHandler
    {
        public void Handle(IJob<IJobData> job)
        {
            Type type = Type.GetType(job.Type);

            switch (type.Name)
            {
                case nameof(AProductSimpleTxtReport):
                    Logging.Log().Information("Handling job {job}", nameof(AProductSimpleTxtReport));
                    new AProductSimpleTxtReportWorker((AProductSimpleTxtReport)job).Start();
                    break;
            }
        }
    }
}