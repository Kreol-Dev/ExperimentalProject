namespace generators {
    
    
    public class court_member_introduced : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar3 = default(System.Boolean); //IsContext = False IsNew = False
			World StoredVariable0 = root.GetComponent<World>(); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				
				System.Collections.Generic.List<UnityEngine.GameObject> OperandVar2 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
				System.Collections.Generic.List<UnityEngine.GameObject> prop1 = StoredVariable0.Objects; //IsContext = False IsNew = False
				if(prop1 != null)
				{
					OperandVar2 = prop1;
				} else { UnityEngine.Debug.Log("prop1 != null = false " ); }
				
				
				if(( ( (OperandVar2 != null ? OperandVar2.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar3 = applicable;
				} else { UnityEngine.Debug.Log("( ( (OperandVar2 != null ? OperandVar2.Count : 0))) == ( ( (0f))) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable0 != null = false " ); }
			return (System.Boolean) (OperandVar3);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				World subContext4 = root.GetComponent<World>(); //IsContext = True IsNew = False
				
				if(subContext4 != null)
				{
					
					for (int i = 0; i <  (5f); i++)
					{
						UnityEngine.GameObject court_member = new UnityEngine.GameObject("court_member"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject court_member5 = court_member; //IsContext = True IsNew = False
							Actor AddContext6 = court_member.AddComponent<Actor>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext6 != null)
								{
									
									
									
									System.Single OperandVar8 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop7 = External.Random( (0f), (1000000f)); //IsContext = False IsNew = False
									OperandVar8 = prop7;
									AddContext6.Name = ( ( ("Courtier"))) + ( ( (OperandVar8)));
								} else { UnityEngine.Debug.Log("AddContext6 != null = false " ); }
							}
							Traits AddContext9 = court_member.AddComponent<Traits>(); //IsContext = True IsNew = True
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(court_member);
						UnityEngine.GameObject OperandVar10 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar10 = court_member;
						subContext4.Attach( (OperandVar10));
					}
				} else { UnityEngine.Debug.Log("subContext4 != null = false " ); }
			}
		}
        }
    }
    
    public class events_data_added : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar16 = default(System.Boolean); //IsContext = False IsNew = False
			World StoredVariable11 = root.GetComponent<World>(); //IsContext = False IsNew = False
			if(StoredVariable11 != null)
			{
				System.Boolean OperandVar15 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.events_data OperandVar13 = default(Blackboards.events_data); //IsContext = False IsNew = False
				Blackboards.events_data StoredVariable12 = StoredVariable11.GetComponent<Blackboards.events_data>(); //IsContext = False IsNew = False
				if(StoredVariable12 != null)
				{
					OperandVar13 = StoredVariable12;
				} else { UnityEngine.Debug.Log("StoredVariable12 != null = false " ); }
				System.Boolean prop14 = External.Has( (OperandVar13)); //IsContext = False IsNew = False
				OperandVar15 = prop14;
				if(!(OperandVar15))
				{
					applicable = true;
					OperandVar16 = applicable;
				} else { UnityEngine.Debug.Log("!(OperandVar15) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable11 != null = false " ); }
			return (System.Boolean) (OperandVar16);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			root.AddComponent<Blackboards.events_data>();
		}
        }
    }
    
    public class personality_added : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar22 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable17 = root.GetComponent<Actor>(); //IsContext = False IsNew = False
			if(StoredVariable17 != null)
			{
				System.Boolean OperandVar21 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar19 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable18 = StoredVariable17.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
				if(StoredVariable18 != null)
				{
					OperandVar19 = StoredVariable18;
				} else { UnityEngine.Debug.Log("StoredVariable18 != null = false " ); }
				System.Boolean prop20 = External.Has( (OperandVar19)); //IsContext = False IsNew = False
				OperandVar21 = prop20;
				if(!(OperandVar21))
				{
					applicable = true;
					OperandVar22 = applicable;
				} else { UnityEngine.Debug.Log("!(OperandVar21) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable17 != null = false " ); }
			return (System.Boolean) (OperandVar22);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			Blackboards.personality ContextVar23 = root.AddComponent<Blackboards.personality>();; //IsContext = False IsNew = True
			
			{
				
				if(ContextVar23 != null)
				{
					System.Single OperandVar25 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop24 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar25 = prop24;
					ContextVar23.Cruelty =  (OperandVar25);
					System.Single OperandVar27 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop26 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar27 = prop26;
					ContextVar23.Rationality =  (OperandVar27);
					System.Single OperandVar29 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop28 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar29 = prop28;
					ContextVar23.Generosity =  (OperandVar29);
					System.Single OperandVar31 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop30 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar31 = prop30;
					ContextVar23.Zealotry =  (OperandVar31);
				} else { UnityEngine.Debug.Log("ContextVar23 != null = false " ); }
			}
		}
        }
    }
    
    public class burn_the_wizard : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar40 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable32 = root.GetComponent<Actor>(); //IsContext = False IsNew = False
			if(StoredVariable32 != null)
			{
				Blackboards.personality StoredVariable33 = StoredVariable32.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
				if(StoredVariable33 != null)
				{
					
					
					System.Single OperandVar35 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop34 = StoredVariable33.Cruelty; //IsContext = False IsNew = False
					OperandVar35 = prop34;
					
					
					
					
					System.Single OperandVar37 = default(System.Single); //IsContext = False IsNew = False
					if(StoredVariable33 != null)
					{
						System.Single prop36 = StoredVariable33.Rationality; //IsContext = False IsNew = False
						OperandVar37 = prop36;
					} else { UnityEngine.Debug.Log("StoredVariable33 != null = false " ); }
					
					
					
					
					System.Single OperandVar39 = default(System.Single); //IsContext = False IsNew = False
					if(StoredVariable33 != null)
					{
						System.Single prop38 = StoredVariable33.Zealotry; //IsContext = False IsNew = False
						OperandVar39 = prop38;
					} else { UnityEngine.Debug.Log("StoredVariable33 != null = false " ); }
					
					
					if(( (( ( (OperandVar35))) > ( ( (0.5f))))) && ( (( ( (OperandVar37))) < ( ( (0.5f))))) && ( (( ( (OperandVar39))) > ( ( (0.5f))))))
					{
						applicable = true;
						OperandVar40 = applicable;
					} else { UnityEngine.Debug.Log("( (( ( (OperandVar35))) > ( ( (0.5f))))) && ( (( ( (OperandVar37))) < ( ( (0.5f))))) && ( (( ( (OperandVar39))) > ( ( (0.5f))))) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable33 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable32 != null = false " ); }
			return (System.Boolean) (OperandVar40);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			{
				World FuncCtx41 = External.GetWorld();; //IsContext = True IsNew = False
				
				if(FuncCtx41 != null)
				{
					
					{
						Blackboards.events_data subContext42 = FuncCtx41.GetComponent<Blackboards.events_data>(); //IsContext = True IsNew = False
						
						if(subContext42 != null)
						{
							
							External.Log( ("IS IT NECCESSARY TO KILL A WITH?"));
							System.Boolean OperandVar46 = default(System.Boolean); //IsContext = False IsNew = False
							UnityEngine.GameObject OperandVar44 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							UnityEngine.GameObject prop43 = subContext42.Wizard; //IsContext = False IsNew = False
							if(prop43 != null)
							{
								OperandVar44 = prop43;
							} else { UnityEngine.Debug.Log("prop43 != null = false " ); }
							System.Boolean prop45 = External.Has( (OperandVar44)); //IsContext = False IsNew = False
							OperandVar46 = prop45;
							if(!(OperandVar46))
							{
								
								External.Log( ("SEARCHING FOR THE WITCH"));
								UnityEngine.GameObject OperandVar55 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								System.Collections.Generic.List<UnityEngine.GameObject> OperandVar48 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
								if(FuncCtx41 != null)
								{
									System.Collections.Generic.List<UnityEngine.GameObject> prop47 = FuncCtx41.Objects; //IsContext = False IsNew = False
									if(prop47 != null)
									{
										OperandVar48 = prop47;
									} else { UnityEngine.Debug.Log("prop47 != null = false " ); }
								} else { UnityEngine.Debug.Log("FuncCtx41 != null = false " ); }
								UnityEngine.GameObject prop54 = External.SelectFrom( (OperandVar48),(UnityEngine.GameObject go)=>{;
;
;
System.Single OperandVar51 = default(System.Single); //IsContext = False IsNew = False;
Blackboards.personality StoredVariable49 = go.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False;
if(StoredVariable49 != null)
									{
										System.Single prop50 = StoredVariable49.Rationality; //IsContext = False IsNew = False
										OperandVar51 = prop50;
									} else { UnityEngine.Debug.Log("StoredVariable49 != null = false " ); };
;
;
;
;
;
UnityEngine.GameObject OperandVar52 = default(UnityEngine.GameObject); //IsContext = False IsNew = False;
OperandVar52 = go;;
;
UnityEngine.GameObject OperandVar53 = default(UnityEngine.GameObject); //IsContext = False IsNew = False;
OperandVar53 = root;;
return ( (( ( (OperandVar51))) > ( ( (0.7f))))) && ( (!(( ( (OperandVar52))) == ( ( (OperandVar53))))));}); //IsContext = False IsNew = False
								if(prop54 != null)
								{
									OperandVar55 = prop54;
								} else { UnityEngine.Debug.Log("prop54 != null = false " ); }
								subContext42.Wizard =  (OperandVar55);
							} else { UnityEngine.Debug.Log("!(OperandVar46) = false " ); }
							
							System.Boolean OperandVar59 = default(System.Boolean); //IsContext = False IsNew = False
							UnityEngine.GameObject OperandVar57 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							UnityEngine.GameObject prop56 = subContext42.Wizard; //IsContext = False IsNew = False
							if(prop56 != null)
							{
								OperandVar57 = prop56;
							} else { UnityEngine.Debug.Log("prop56 != null = false " ); }
							System.Boolean prop58 = External.Has( (OperandVar57)); //IsContext = False IsNew = False
							OperandVar59 = prop58;
							
							System.Boolean OperandVar61 = default(System.Boolean); //IsContext = False IsNew = False
							if(subContext42 != null)
							{
								System.Boolean prop60 = subContext42.WizardBurned; //IsContext = False IsNew = False
								OperandVar61 = prop60;
							} else { UnityEngine.Debug.Log("subContext42 != null = false " ); }
							if(( ( (OperandVar59))) && ( (!(OperandVar61))))
							{
								
								External.Log( ("FOUND THE WITCH"));
								
								System.Single OperandVar64 = default(System.Single); //IsContext = False IsNew = False
								Blackboards.personality StoredVariable62 = root.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
								if(StoredVariable62 != null)
								{
									System.Single prop63 = StoredVariable62.Cruelty; //IsContext = False IsNew = False
									OperandVar64 = prop63;
								} else { UnityEngine.Debug.Log("StoredVariable62 != null = false " ); }
								
								
								System.Single OperandVar66 = default(System.Single); //IsContext = False IsNew = False
								if(StoredVariable62 != null)
								{
									System.Single prop65 = StoredVariable62.Zealotry; //IsContext = False IsNew = False
									OperandVar66 = prop65;
								} else { UnityEngine.Debug.Log("StoredVariable62 != null = false " ); }
								
								
								System.Single OperandVar69 = default(System.Single); //IsContext = False IsNew = False
								if(subContext42 != null)
								{
									UnityEngine.GameObject prop67 = subContext42.Wizard; //IsContext = False IsNew = False
									if(prop67 != null)
									{
										if(StoredVariable62 != null)
										{
											System.Single prop68 = StoredVariable62.Rationality; //IsContext = False IsNew = False
											OperandVar69 = prop68;
										} else { UnityEngine.Debug.Log("StoredVariable62 != null = false " ); }
									} else { UnityEngine.Debug.Log("prop67 != null = false " ); }
								} else { UnityEngine.Debug.Log("subContext42 != null = false " ); }
								
								ut = ( (( (OperandVar64)) * ( (0.33f)))) + ( (( (OperandVar66)) * ( (0.33f)))) + ( (( (OperandVar69)) * ( (0.33f))));
							} else { UnityEngine.Debug.Log("( ( (OperandVar59))) && ( (!(OperandVar61))) = false " ); }
						} else { UnityEngine.Debug.Log("subContext42 != null = false " ); }
					}
				} else { UnityEngine.Debug.Log("FuncCtx41 != null = false " ); }
			}
			return ut;
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			External.Log( ("BURN THE WITCH"));
			
			{
				World FuncCtx70 = External.GetWorld();; //IsContext = True IsNew = False
				
				if(FuncCtx70 != null)
				{
					
					{
						Blackboards.events_data subContext71 = FuncCtx70.GetComponent<Blackboards.events_data>(); //IsContext = True IsNew = False
						
						if(subContext71 != null)
						{
							
							subContext71.WizardBurned =  (true);
						} else { UnityEngine.Debug.Log("subContext71 != null = false " ); }
					}
				} else { UnityEngine.Debug.Log("FuncCtx70 != null = false " ); }
			}
			UnityEngine.GameObject wizard_event = new UnityEngine.GameObject("wizard_event"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject wizard_event72 = wizard_event; //IsContext = True IsNew = False
				Event AddContext73 = wizard_event.AddComponent<Event>(); //IsContext = True IsNew = True
				
				{
					
					if(AddContext73 != null)
					{
						Actor OperandVar75 = default(Actor); //IsContext = False IsNew = False
						Actor StoredVariable74 = root.GetComponent<Actor>(); //IsContext = False IsNew = False
						if(StoredVariable74 != null)
						{
							OperandVar75 = StoredVariable74;
						} else { UnityEngine.Debug.Log("StoredVariable74 != null = false " ); }
						AddContext73.Involved =  (OperandVar75);
						Blackboards.burn_event act = wizard_event72.AddComponent<Blackboards.burn_event>();; //IsContext = False IsNew = True
						
						{
							
							if(act != null)
							{
								UnityEngine.GameObject OperandVar79 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								World prop76 = External.GetWorld(); //IsContext = False IsNew = False
								if(prop76 != null)
								{
									Blackboards.events_data StoredVariable77 = prop76.GetComponent<Blackboards.events_data>(); //IsContext = False IsNew = False
									if(StoredVariable77 != null)
									{
										UnityEngine.GameObject prop78 = StoredVariable77.Wizard; //IsContext = False IsNew = False
										if(prop78 != null)
										{
											OperandVar79 = prop78;
										} else { UnityEngine.Debug.Log("prop78 != null = false " ); }
									} else { UnityEngine.Debug.Log("StoredVariable77 != null = false " ); }
								} else { UnityEngine.Debug.Log("prop76 != null = false " ); }
								act.Target =  (OperandVar79);
							} else { UnityEngine.Debug.Log("act != null = false " ); }
						}
						Blackboards.burn_event OperandVar80 = default(Blackboards.burn_event); //IsContext = False IsNew = False
						OperandVar80 = act;
						AddContext73.Action =  (OperandVar80);
					} else { UnityEngine.Debug.Log("AddContext73 != null = false " ); }
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(wizard_event);
		}
        }
    }
    
    public class burn_wizard_desc : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar83 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable81 = root.GetComponent<Event>(); //IsContext = False IsNew = False
			if(StoredVariable81 != null)
			{
				Blackboards.burn_event StoredVariable82 = StoredVariable81.GetComponent<Blackboards.burn_event>(); //IsContext = False IsNew = False
				if(StoredVariable82 != null)
				{
					applicable = true;
					OperandVar83 = applicable;
				} else { UnityEngine.Debug.Log("StoredVariable82 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable81 != null = false " ); }
			return (System.Boolean) (OperandVar83);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			System.Boolean OperandVar86 = default(System.Boolean); //IsContext = False IsNew = False
			EventsController prop84 = External.GetEventsController(); //IsContext = False IsNew = False
			if(prop84 != null)
			{
				System.Boolean prop85 = prop84.HasDesc; //IsContext = False IsNew = False
				OperandVar86 = prop85;
			} else { UnityEngine.Debug.Log("prop84 != null = false " ); }
			if(!(OperandVar86))
			{
				
				ut =  (1f);
			} else { UnityEngine.Debug.Log("!(OperandVar86) = false " ); }
			return ut;
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				EventsController FuncCtx87 = External.GetEventsController();; //IsContext = True IsNew = False
				
				if(FuncCtx87 != null)
				{
					
					FuncCtx87.HasDesc =  (true);
					
					System.String OperandVar91 = default(System.String); //IsContext = False IsNew = False
					Event StoredVariable88 = root.GetComponent<Event>(); //IsContext = False IsNew = False
					if(StoredVariable88 != null)
					{
						Actor prop89 = StoredVariable88.Involved; //IsContext = False IsNew = False
						if(prop89 != null)
						{
							System.String prop90 = prop89.Name; //IsContext = False IsNew = False
							if(prop90 != null)
							{
								OperandVar91 = prop90;
							} else { UnityEngine.Debug.Log("prop90 != null = false " ); }
						} else { UnityEngine.Debug.Log("prop89 != null = false " ); }
					} else { UnityEngine.Debug.Log("StoredVariable88 != null = false " ); }
					
					
					
					System.String OperandVar96 = default(System.String); //IsContext = False IsNew = False
					Blackboards.burn_event StoredVariable92 = root.GetComponent<Blackboards.burn_event>(); //IsContext = False IsNew = False
					if(StoredVariable92 != null)
					{
						UnityEngine.GameObject prop93 = StoredVariable92.Target; //IsContext = False IsNew = False
						if(prop93 != null)
						{
							Actor StoredVariable94 = prop93.GetComponent<Actor>(); //IsContext = False IsNew = False
							if(StoredVariable94 != null)
							{
								System.String prop95 = StoredVariable94.Name; //IsContext = False IsNew = False
								if(prop95 != null)
								{
									OperandVar96 = prop95;
								} else { UnityEngine.Debug.Log("prop95 != null = false " ); }
							} else { UnityEngine.Debug.Log("StoredVariable94 != null = false " ); }
						} else { UnityEngine.Debug.Log("prop93 != null = false " ); }
					} else { UnityEngine.Debug.Log("StoredVariable92 != null = false " ); }
					FuncCtx87.EventDescription(( ( (OperandVar91))) + ( ( (" gonna burn the wizard. This wizard is known by name "))) + ( ( (OperandVar96))));
				} else { UnityEngine.Debug.Log("FuncCtx87 != null = false " ); }
			}
		}
        }
    }
    
    public class burn_wizard_reaction_watch : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar104 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable97 = root.GetComponent<Event>(); //IsContext = False IsNew = False
			if(StoredVariable97 != null)
			{
				Blackboards.burn_event StoredVariable98 = StoredVariable97.GetComponent<Blackboards.burn_event>(); //IsContext = False IsNew = False
				if(StoredVariable98 != null)
				{
					
					
					System.Boolean OperandVar100 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop99 = StoredVariable98.ChurchReaction; //IsContext = False IsNew = False
					OperandVar100 = prop99;
					
					
					
					
					System.Single OperandVar103 = default(System.Single); //IsContext = False IsNew = False
					Player prop101 = External.GetPlayer(); //IsContext = False IsNew = False
					if(prop101 != null)
					{
						System.Single prop102 = prop101.Church; //IsContext = False IsNew = False
						OperandVar103 = prop102;
					} else { UnityEngine.Debug.Log("prop101 != null = false " ); }
					
					
					if(( (( ( (OperandVar100))) == ( ( (false))))) && ( (( ( (OperandVar103))) > ( ( (45f))))))
					{
						applicable = true;
						OperandVar104 = applicable;
					} else { UnityEngine.Debug.Log("( (( ( (OperandVar100))) == ( ( (false))))) && ( (( ( (OperandVar103))) > ( ( (45f))))) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable98 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable97 != null = false " ); }
			return (System.Boolean) (OperandVar104);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				Blackboards.burn_event subContext105 = root.GetComponent<Blackboards.burn_event>(); //IsContext = True IsNew = False
				
				if(subContext105 != null)
				{
					
					subContext105.ChurchReaction =  (true);
				} else { UnityEngine.Debug.Log("subContext105 != null = false " ); }
			}
			
			{
				EventsController FuncCtx106 = External.GetEventsController();; //IsContext = True IsNew = False
				
				if(FuncCtx106 != null)
				{
					
					VoidDelegate Lambda107 = () => 
					{
						UnityEngine.GameObject OperandVar108 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar108 = root;
						External.Log( (OperandVar108));
						UnityEngine.GameObject OperandVar111 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						Blackboards.burn_event StoredVariable109 = root.GetComponent<Blackboards.burn_event>(); //IsContext = False IsNew = False
						if(StoredVariable109 != null)
						{
							UnityEngine.GameObject prop110 = StoredVariable109.Target; //IsContext = False IsNew = False
							if(prop110 != null)
							{
								OperandVar111 = prop110;
							} else { UnityEngine.Debug.Log("prop110 != null = false " ); }
						} else { UnityEngine.Debug.Log("StoredVariable109 != null = false " ); }
						External.Destroy( (OperandVar111));
						Event OperandVar113 = default(Event); //IsContext = False IsNew = False
						Event StoredVariable112 = FuncCtx106.GetComponent<Event>(); //IsContext = False IsNew = False
						if(StoredVariable112 != null)
						{
							OperandVar113 = StoredVariable112;
						} else { UnityEngine.Debug.Log("StoredVariable112 != null = false " ); }
						External.Destroy( (OperandVar113));
						
						{
							Player FuncCtx114 = External.GetPlayer();; //IsContext = True IsNew = False
							
							if(FuncCtx114 != null)
							{
								
								System.Single OperandVar116 = default(System.Single); //IsContext = False IsNew = False
								System.Single prop115 = FuncCtx114.Church; //IsContext = False IsNew = False
								OperandVar116 = prop115;
								
								
								FuncCtx114.Church = ( ( (OperandVar116))) + ( ( (10f)));
							} else { UnityEngine.Debug.Log("FuncCtx114 != null = false " ); }
						}
						
						{
							World FuncCtx117 = External.GetWorld();; //IsContext = True IsNew = False
							
							if(FuncCtx117 != null)
							{
								
								{
									Blackboards.events_data subContext118 = FuncCtx117.GetComponent<Blackboards.events_data>(); //IsContext = True IsNew = False
									
									if(subContext118 != null)
									{
										UnityEngine.GameObject OperandVar120 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
										UnityEngine.GameObject prop119 = External.NoOne(); //IsContext = False IsNew = False
										if(prop119 != null)
										{
											OperandVar120 = prop119;
										} else { UnityEngine.Debug.Log("prop119 != null = false " ); }
										subContext118.Wizard =  (OperandVar120);
										
										subContext118.WizardBurned =  (false);
									} else { UnityEngine.Debug.Log("subContext118 != null = false " ); }
								}
							} else { UnityEngine.Debug.Log("FuncCtx117 != null = false " ); }
						}
					};
					FuncCtx106.Reaction( ("Let him burn"),Lambda107);
				} else { UnityEngine.Debug.Log("FuncCtx106 != null = false " ); }
			}
		}
        }
    }
    
    public class burn_wizard_reaction_kill : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar128 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable121 = root.GetComponent<Event>(); //IsContext = False IsNew = False
			if(StoredVariable121 != null)
			{
				Blackboards.burn_event StoredVariable122 = StoredVariable121.GetComponent<Blackboards.burn_event>(); //IsContext = False IsNew = False
				if(StoredVariable122 != null)
				{
					
					
					System.Boolean OperandVar124 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop123 = StoredVariable122.KillReaction; //IsContext = False IsNew = False
					OperandVar124 = prop123;
					
					
					
					
					System.Single OperandVar127 = default(System.Single); //IsContext = False IsNew = False
					Player prop125 = External.GetPlayer(); //IsContext = False IsNew = False
					if(prop125 != null)
					{
						System.Single prop126 = prop125.Church; //IsContext = False IsNew = False
						OperandVar127 = prop126;
					} else { UnityEngine.Debug.Log("prop125 != null = false " ); }
					
					
					if(( (( ( (OperandVar124))) == ( ( (false))))) && ( (( ( (OperandVar127))) <=( ( (75f))))))
					{
						applicable = true;
						OperandVar128 = applicable;
					} else { UnityEngine.Debug.Log("( (( ( (OperandVar124))) == ( ( (false))))) && ( (( ( (OperandVar127))) <=( ( (75f))))) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable122 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable121 != null = false " ); }
			return (System.Boolean) (OperandVar128);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				Blackboards.burn_event subContext129 = root.GetComponent<Blackboards.burn_event>(); //IsContext = True IsNew = False
				
				if(subContext129 != null)
				{
					
					subContext129.KillReaction =  (true);
				} else { UnityEngine.Debug.Log("subContext129 != null = false " ); }
			}
			
			{
				EventsController FuncCtx130 = External.GetEventsController();; //IsContext = True IsNew = False
				
				if(FuncCtx130 != null)
				{
					
					VoidDelegate Lambda131 = () => 
					{
						UnityEngine.GameObject OperandVar132 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar132 = root;
						External.Log( (OperandVar132));
						Actor OperandVar135 = default(Actor); //IsContext = False IsNew = False
						Event StoredVariable133 = root.GetComponent<Event>(); //IsContext = False IsNew = False
						if(StoredVariable133 != null)
						{
							Actor prop134 = StoredVariable133.Involved; //IsContext = False IsNew = False
							if(prop134 != null)
							{
								OperandVar135 = prop134;
							} else { UnityEngine.Debug.Log("prop134 != null = false " ); }
						} else { UnityEngine.Debug.Log("StoredVariable133 != null = false " ); }
						External.Destroy( (OperandVar135));
						Event OperandVar136 = default(Event); //IsContext = False IsNew = False
						if(StoredVariable133 != null)
						{
							OperandVar136 = StoredVariable133;
						} else { UnityEngine.Debug.Log("StoredVariable133 != null = false " ); }
						External.Destroy( (OperandVar136));
						
						{
							Player FuncCtx137 = External.GetPlayer();; //IsContext = True IsNew = False
							
							if(FuncCtx137 != null)
							{
								
								System.Single OperandVar139 = default(System.Single); //IsContext = False IsNew = False
								System.Single prop138 = FuncCtx137.Church; //IsContext = False IsNew = False
								OperandVar139 = prop138;
								
								
								FuncCtx137.Church = ( ( (OperandVar139))) - ( ( (10f)));
							} else { UnityEngine.Debug.Log("FuncCtx137 != null = false " ); }
						}
						
						{
							World FuncCtx140 = External.GetWorld();; //IsContext = True IsNew = False
							
							if(FuncCtx140 != null)
							{
								
								{
									Blackboards.events_data subContext141 = FuncCtx140.GetComponent<Blackboards.events_data>(); //IsContext = True IsNew = False
									
									if(subContext141 != null)
									{
										UnityEngine.GameObject OperandVar143 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
										UnityEngine.GameObject prop142 = External.NoOne(); //IsContext = False IsNew = False
										if(prop142 != null)
										{
											OperandVar143 = prop142;
										} else { UnityEngine.Debug.Log("prop142 != null = false " ); }
										subContext141.Wizard =  (OperandVar143);
										
										subContext141.WizardBurned =  (false);
									} else { UnityEngine.Debug.Log("subContext141 != null = false " ); }
								}
							} else { UnityEngine.Debug.Log("FuncCtx140 != null = false " ); }
						}
					};
					FuncCtx130.Reaction( ("I can't tolerate such atrocity, kill him and free the guy"),Lambda131);
				} else { UnityEngine.Debug.Log("FuncCtx130 != null = false " ); }
			}
		}
        }
    }
}
