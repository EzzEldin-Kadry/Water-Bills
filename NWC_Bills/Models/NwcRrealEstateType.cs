using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NWC_Bills.Models;

public partial class NwcRrealEstateType
{
    [Key]
    [Required(ErrorMessage = "رقم العقار مطلوب")]
    [StringLength(1, ErrorMessage = "يجب ألا يتخطى الرقم 9")]
    public string NwcRrealEstateTypesCode { get; set; } = null!;
    [Required(ErrorMessage = "إسم العقار مطلوب")]
    [StringLength(15,ErrorMessage ="يجب أن يتكون الإسم من 1 إلى 15 حرف")]
    public string NwcRrealEstateTypesName { get; set; }
    [StringLength(100, ErrorMessage = "لقد تعديت الحد المسموح به من الحروف")]
    public string? NwcRrealEstateTypesReasons { get; set; }
}
