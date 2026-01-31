using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public enum UserRole { Guest, User, GroupOwner, Staff, Admin }
    public enum Region { Bac, Trung, Nam }
    public enum TeamRole { Member, Leader }
    public enum TaskType { ChapterCompletion, CoinsTarget, StarsTarget, AccuracyTarget, StreakTarget }
    public enum TaskStatus { Pending, InProgress, Completed, Failed }
    public enum ReportType { Bug, Abuse, Content }
    public enum ReportStatus { Pending, Investigated, Resolved }
    public enum ContentType { Lesson, Question }
}
