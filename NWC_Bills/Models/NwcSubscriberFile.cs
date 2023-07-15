using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NWC_Bills.Models;

public partial class NwcSubscriberFile
{
    [Key]
    [Required(ErrorMessage = "رقم الهوية مطلوب")]
    [StringLength(10, ErrorMessage = "يجب ألا يتخطي الرقم 10 خانات")]
    public string NwcSubscriberFileId { get; set; } = null!;
    [Required(ErrorMessage = "الاسم مطلوب")]
    [StringLength(100, ErrorMessage = "لقد تعديت الحد المسموح به من الحروف")]
    public string NwcSubscriberFileName { get; set; } = null!;
    [Required(ErrorMessage = "هذا الحقل مطلوب")]
    [StringLength(50, ErrorMessage = "لقد تعديت الحد المسموح به من الحروف")]
    public string NwcSubscriberFileCity { get; set; } = null!;
    [Required(ErrorMessage = "هذا الحقل مطلوب")]
    [StringLength(50, ErrorMessage = "لقد تعديت الحد المسموح به من الحروف")]
    public string NwcSubscriberFileArea { get; set; } = null!;
    [Required(ErrorMessage = "هذا الحقل مطلوب")]
    [StringLength(20, ErrorMessage = "لقد تعديت الحد المسموح به من الحروف")]
    public string? NwcSubscriberFileMobile { get; set; }

    public string? NwcSubscriptionFileReasons { get; set; }

    public virtual ICollection<NwcInvoice> NwcInvoices { get; set; } = new List<NwcInvoice>();

    public virtual ICollection<NwcSubscriptionFile> NwcSubscriptionFiles { get; set; } = new List<NwcSubscriptionFile>();
}
