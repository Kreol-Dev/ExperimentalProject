namespace generators {
    
    
    public class court_member_introduced : EventAction {
        
        public override bool Filter() {

		{
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
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
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
							Traits AddContext7 = court_member.AddComponent<Traits>(); //IsContext = True IsNew = True
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(court_member);
						UnityEngine.GameObject OperandVar8 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar8 = court_member;
						subContext4.Attach( (OperandVar8));
					}
				} else { UnityEngine.Debug.Log("subContext4 != null = false " ); }
			}
		}
        }
    }
    
    public class events_data_added : EventAction {
        
        public override bool Filter() {

		{
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar14 = default(System.Boolean); //IsContext = False IsNew = False
			World StoredVariable9 = root.GetComponent<World>(); //IsContext = False IsNew = False
			if(StoredVariable9 != null)
			{
				System.Boolean OperandVar13 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.events_data OperandVar11 = default(Blackboards.events_data); //IsContext = False IsNew = False
				Blackboards.events_data StoredVariable10 = StoredVariable9.GetComponent<Blackboards.events_data>(); //IsContext = False IsNew = False
				if(StoredVariable10 != null)
				{
					OperandVar11 = StoredVariable10;
				} else { UnityEngine.Debug.Log("StoredVariable10 != null = false " ); }
				System.Boolean prop12 = External.Has( (OperandVar11)); //IsContext = False IsNew = False
				OperandVar13 = prop12;
				if(!(OperandVar13))
				{
					applicable = true;
					OperandVar14 = applicable;
				} else { UnityEngine.Debug.Log("!(OperandVar13) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable9 != null = false " ); }
			return (System.Boolean) (OperandVar14);
		}
        }
        
        public override float Utility() {

		{
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			UnityEngine.Debug.Log(root);
			
			
			
			root.AddComponent<Blackboards.events_data>();
		}
        }
    }
    
    public class personality_added : EventAction {
        
        public override bool Filter() {

		{
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar20 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable15 = root.GetComponent<Actor>(); //IsContext = False IsNew = False
			if(StoredVariable15 != null)
			{
				System.Boolean OperandVar19 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar17 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable16 = StoredVariable15.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
				if(StoredVariable16 != null)
				{
					OperandVar17 = StoredVariable16;
				} else { UnityEngine.Debug.Log("StoredVariable16 != null = false " ); }
				System.Boolean prop18 = External.Has( (OperandVar17)); //IsContext = False IsNew = False
				OperandVar19 = prop18;
				if(!(OperandVar19))
				{
					applicable = true;
					OperandVar20 = applicable;
				} else { UnityEngine.Debug.Log("!(OperandVar19) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable15 != null = false " ); }
			return (System.Boolean) (OperandVar20);
		}
        }
        
        public override float Utility() {

		{
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			UnityEngine.Debug.Log(root);
			
			
			
			Blackboards.personality ContextVar21 = root.AddComponent<Blackboards.personality>();; //IsContext = False IsNew = True
			
			{
				
				if(ContextVar21 != null)
				{
					System.Single OperandVar23 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop22 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar23 = prop22;
					ContextVar21.Cruelty =  (OperandVar23);
					System.Single OperandVar25 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop24 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar25 = prop24;
					ContextVar21.Rationality =  (OperandVar25);
					System.Single OperandVar27 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop26 = External.Random( (0f), (1f)); //IsContext = False IsNew = False
					OperandVar27 = prop26;
					ContextVar21.Generosity =  (OperandVar27);
					System.Single OperandVar29 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop28 = External.Random( (0.4f), (1f)); //IsContext = False IsNew = False
					OperandVar29 = prop28;
					ContextVar21.Zealotry =  (OperandVar29);
				} else { UnityEngine.Debug.Log("ContextVar21 != null = false " ); }
			}
		}
        }
    }
    
    public class burn_the_wizard : EventAction {
        
        public override bool Filter() {

		{
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar38 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable30 = root.GetComponent<Actor>(); //IsContext = False IsNew = False
			if(StoredVariable30 != null)
			{
				Blackboards.personality StoredVariable31 = StoredVariable30.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
				if(StoredVariable31 != null)
				{
					
					
					System.Single OperandVar33 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop32 = StoredVariable31.Cruelty; //IsContext = False IsNew = False
					OperandVar33 = prop32;
					
					
					
					
					System.Single OperandVar35 = default(System.Single); //IsContext = False IsNew = False
					if(StoredVariable31 != null)
					{
						System.Single prop34 = StoredVariable31.Rationality; //IsContext = False IsNew = False
						OperandVar35 = prop34;
					} else { UnityEngine.Debug.Log("StoredVariable31 != null = false " ); }
					
					
					
					
					System.Single OperandVar37 = default(System.Single); //IsContext = False IsNew = False
					if(StoredVariable31 != null)
					{
						System.Single prop36 = StoredVariable31.Zealotry; //IsContext = False IsNew = False
						OperandVar37 = prop36;
					} else { UnityEngine.Debug.Log("StoredVariable31 != null = false " ); }
					
					
					if(( (( ( (OperandVar33))) > ( ( (0.5f))))) && ( (( ( (OperandVar35))) < ( ( (0.5f))))) && ( (( ( (OperandVar37))) > ( ( (0.5f))))))
					{
						applicable = true;
						OperandVar38 = applicable;
					} else { UnityEngine.Debug.Log("( (( ( (OperandVar33))) > ( ( (0.5f))))) && ( (( ( (OperandVar35))) < ( ( (0.5f))))) && ( (( ( (OperandVar37))) > ( ( (0.5f))))) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable31 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable30 != null = false " ); }
			return (System.Boolean) (OperandVar38);
		}
        }
        
        public override float Utility() {

		{
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			{
				World FuncCtx39 = External.GetWorld();; //IsContext = True IsNew = False
				
				if(FuncCtx39 != null)
				{
					
					{
						Blackboards.events_data subContext40 = FuncCtx39.GetComponent<Blackboards.events_data>(); //IsContext = True IsNew = False
						
						if(subContext40 != null)
						{
							
							External.Log( ("IS IT NECCESSARY TO KILL A WITH?"));
							System.Boolean OperandVar44 = default(System.Boolean); //IsContext = False IsNew = False
							UnityEngine.GameObject OperandVar42 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							UnityEngine.GameObject prop41 = subContext40.Wizard; //IsContext = False IsNew = False
							if(prop41 != null)
							{
								OperandVar42 = prop41;
							} else { UnityEngine.Debug.Log("prop41 != null = false " ); }
							System.Boolean prop43 = External.Has( (OperandVar42)); //IsContext = False IsNew = False
							OperandVar44 = prop43;
							if(!(OperandVar44))
							{
								
								External.Log( ("SEARCHING FOR THE WITCH"));
								UnityEngine.GameObject OperandVar53 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								System.Collections.Generic.List<UnityEngine.GameObject> OperandVar46 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
								if(FuncCtx39 != null)
								{
									System.Collections.Generic.List<UnityEngine.GameObject> prop45 = FuncCtx39.Objects; //IsContext = False IsNew = False
									if(prop45 != null)
									{
										OperandVar46 = prop45;
									} else { UnityEngine.Debug.Log("prop45 != null = false " ); }
								} else { UnityEngine.Debug.Log("FuncCtx39 != null = false " ); }
								UnityEngine.GameObject prop52 = External.SelectFrom( (OperandVar46),(UnityEngine.GameObject go)=>{;
;
;
System.Single OperandVar49 = default(System.Single); //IsContext = False IsNew = False;
Blackboards.personality StoredVariable47 = go.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False;
if(StoredVariable47 != null)
									{
										System.Single prop48 = StoredVariable47.Rationality; //IsContext = False IsNew = False
										OperandVar49 = prop48;
									} else { UnityEngine.Debug.Log("StoredVariable47 != null = false " ); };
;
;
;
;
;
UnityEngine.GameObject OperandVar50 = default(UnityEngine.GameObject); //IsContext = False IsNew = False;
OperandVar50 = go;;
;
UnityEngine.GameObject OperandVar51 = default(UnityEngine.GameObject); //IsContext = False IsNew = False;
OperandVar51 = root;;
return ( (( ( (OperandVar49))) > ( ( (0.7f))))) && ( (!(( ( (OperandVar50))) == ( ( (OperandVar51))))));}); //IsContext = False IsNew = False
								if(prop52 != null)
								{
									OperandVar53 = prop52;
								} else { UnityEngine.Debug.Log("prop52 != null = false " ); }
								subContext40.Wizard =  (OperandVar53);
							} else { UnityEngine.Debug.Log("!(OperandVar44) = false " ); }
							
							System.Boolean OperandVar57 = default(System.Boolean); //IsContext = False IsNew = False
							UnityEngine.GameObject OperandVar55 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							UnityEngine.GameObject prop54 = subContext40.Wizard; //IsContext = False IsNew = False
							if(prop54 != null)
							{
								OperandVar55 = prop54;
							} else { UnityEngine.Debug.Log("prop54 != null = false " ); }
							System.Boolean prop56 = External.Has( (OperandVar55)); //IsContext = False IsNew = False
							OperandVar57 = prop56;
							
							System.Boolean OperandVar59 = default(System.Boolean); //IsContext = False IsNew = False
							if(subContext40 != null)
							{
								System.Boolean prop58 = subContext40.WizardBurned; //IsContext = False IsNew = False
								OperandVar59 = prop58;
							} else { UnityEngine.Debug.Log("subContext40 != null = false " ); }
							if(( ( (OperandVar57))) && ( (!(OperandVar59))))
							{
								
								External.Log( ("FOUND THE WITCH"));
								
								System.Single OperandVar62 = default(System.Single); //IsContext = False IsNew = False
								Blackboards.personality StoredVariable60 = root.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
								if(StoredVariable60 != null)
								{
									System.Single prop61 = StoredVariable60.Cruelty; //IsContext = False IsNew = False
									OperandVar62 = prop61;
								} else { UnityEngine.Debug.Log("StoredVariable60 != null = false " ); }
								
								
								System.Single OperandVar64 = default(System.Single); //IsContext = False IsNew = False
								if(StoredVariable60 != null)
								{
									System.Single prop63 = StoredVariable60.Zealotry; //IsContext = False IsNew = False
									OperandVar64 = prop63;
								} else { UnityEngine.Debug.Log("StoredVariable60 != null = false " ); }
								
								
								System.Single OperandVar67 = default(System.Single); //IsContext = False IsNew = False
								if(subContext40 != null)
								{
									UnityEngine.GameObject prop65 = subContext40.Wizard; //IsContext = False IsNew = False
									if(prop65 != null)
									{
										if(StoredVariable60 != null)
										{
											System.Single prop66 = StoredVariable60.Rationality; //IsContext = False IsNew = False
											OperandVar67 = prop66;
										} else { UnityEngine.Debug.Log("StoredVariable60 != null = false " ); }
									} else { UnityEngine.Debug.Log("prop65 != null = false " ); }
								} else { UnityEngine.Debug.Log("subContext40 != null = false " ); }
								
								ut = ( (( (OperandVar62)) * ( (0.33f)))) + ( (( (OperandVar64)) * ( (0.33f)))) + ( (( (OperandVar67)) * ( (0.33f))));
							} else { UnityEngine.Debug.Log("( ( (OperandVar57))) && ( (!(OperandVar59))) = false " ); }
						} else { UnityEngine.Debug.Log("subContext40 != null = false " ); }
					}
				} else { UnityEngine.Debug.Log("FuncCtx39 != null = false " ); }
			}
			return ut;
		}
        }
        
        public override void Action() {

		{
			UnityEngine.Debug.Log(root);
			
			
			
			
			External.Log( ("BURN THE WITCH"));
			
			{
				World FuncCtx68 = External.GetWorld();; //IsContext = True IsNew = False
				
				if(FuncCtx68 != null)
				{
					
					{
						Blackboards.events_data subContext69 = FuncCtx68.GetComponent<Blackboards.events_data>(); //IsContext = True IsNew = False
						
						if(subContext69 != null)
						{
							
							subContext69.WizardBurned =  (true);
						} else { UnityEngine.Debug.Log("subContext69 != null = false " ); }
					}
				} else { UnityEngine.Debug.Log("FuncCtx68 != null = false " ); }
			}
			UnityEngine.GameObject wizard_event = new UnityEngine.GameObject("wizard_event"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject wizard_event70 = wizard_event; //IsContext = True IsNew = False
				Event AddContext71 = wizard_event.AddComponent<Event>(); //IsContext = True IsNew = True
				
				{
					
					if(AddContext71 != null)
					{
						Actor OperandVar73 = default(Actor); //IsContext = False IsNew = False
						Actor StoredVariable72 = root.GetComponent<Actor>(); //IsContext = False IsNew = False
						if(StoredVariable72 != null)
						{
							OperandVar73 = StoredVariable72;
						} else { UnityEngine.Debug.Log("StoredVariable72 != null = false " ); }
						AddContext71.Involved =  (OperandVar73);
						Blackboards.burn_event act = wizard_event70.AddComponent<Blackboards.burn_event>();; //IsContext = False IsNew = True
						
						{
							
							if(act != null)
							{
								UnityEngine.GameObject OperandVar77 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								World prop74 = External.GetWorld(); //IsContext = False IsNew = False
								if(prop74 != null)
								{
									Blackboards.events_data StoredVariable75 = prop74.GetComponent<Blackboards.events_data>(); //IsContext = False IsNew = False
									if(StoredVariable75 != null)
									{
										UnityEngine.GameObject prop76 = StoredVariable75.Wizard; //IsContext = False IsNew = False
										if(prop76 != null)
										{
											OperandVar77 = prop76;
										} else { UnityEngine.Debug.Log("prop76 != null = false " ); }
									} else { UnityEngine.Debug.Log("StoredVariable75 != null = false " ); }
								} else { UnityEngine.Debug.Log("prop74 != null = false " ); }
								act.Target =  (OperandVar77);
							} else { UnityEngine.Debug.Log("act != null = false " ); }
						}
						Blackboards.burn_event OperandVar78 = default(Blackboards.burn_event); //IsContext = False IsNew = False
						OperandVar78 = act;
						AddContext71.Action =  (OperandVar78);
					} else { UnityEngine.Debug.Log("AddContext71 != null = false " ); }
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(wizard_event);
		}
        }
    }
}
